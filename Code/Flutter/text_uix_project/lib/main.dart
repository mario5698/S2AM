import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    SystemChrome.setEnabledSystemUIOverlays([SystemUiOverlay.bottom]);
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Raindrop App',
      theme: ThemeData(
        primarySwatch: Colors.red,
        visualDensity: VisualDensity.adaptivePlatformDensity,
      ),
      home: MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Material(
        child: Stack(children: <Widget>[
      Scaffold(
          appBar: AppBar(
            title: Text('Raindrop App'),
          ),
          body: Text('hola')),
      AnimationScreen(color: Theme.of(context).accentColor)
    ]));
  }
}

class StaggeredRaindropAnimation {
  StaggeredRaindropAnimation(this.controller)
      : dropSize = Tween<double>(begin: 0, end: maximumDropSize).animate(
          CurvedAnimation(
            parent: controller,
            curve: Interval(0.0, 0.2, curve: Curves.easeIn),
          ),
        ),
        dropPosition =
            Tween<double>(begin: 0, end: maximumRelativeDropY).animate(
          CurvedAnimation(
            parent: controller,
            curve: Interval(0.2, 0.5, curve: Curves.easeIn),
          ),
        );

  final AnimationController controller;

  final Animation<double> dropSize;
  final Animation<double> dropPosition;

  static final double maximumDropSize = 20;
  static final double maximumRelativeDropY = 0.5;
}

class AnimationScreen extends StatefulWidget {
  AnimationScreen({this.color});

  final Color color;

  @override
  _AnimationScreenState createState() => _AnimationScreenState();
}

class _AnimationScreenState extends State<AnimationScreen>
    with SingleTickerProviderStateMixin {
  Size size = Size.zero;
  AnimationController _controller;
  StaggeredRaindropAnimation _animation;

  @override
  void initState() {
    super.initState();
    _controller = AnimationController(
      duration: const Duration(milliseconds: 3000),
      vsync: this,
    );
    _animation = StaggeredRaindropAnimation(_controller);
    _controller.forward();

    _controller.addListener(() {
      setState(() {});
    });
  }

  @override
  void didChangeDependencies() {
    setState(() {
      size = MediaQuery.of(context).size;
    });
    super.didChangeDependencies();
  }

  @override
  Widget build(BuildContext context) {
    return Stack(children: [
      Container(color: widget.color),
      Positioned(
        top: _animation.dropPosition.value * size.height,
        left: size.width / 2 - _animation.dropSize.value / 2,
        child: SizedBox(
          width: _animation.dropSize.value,
          height: _animation.dropSize.value,
          child: CustomPaint(
            painter: DropPainter(),
          ),
        ),
      )
    ]);
  }

  @override
  void dispose() {
    super.dispose();
    _controller.dispose();
  }
}
