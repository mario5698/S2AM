import 'dart:math';
import 'package:flutter/material.dart';

class AnimatedContainerPage extends StatefulWidget {
  @override
  _AnimatedContainerPageState createState() => _AnimatedContainerPageState();
}

class _AnimatedContainerPageState extends State<AnimatedContainerPage> {
  double _width = 50.0;
  double _heigth = 50.0;
  Color _color = Colors.pink;
  BorderRadiusGeometry _borderRadius = BorderRadius.circular(8.0);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('data'),
      ),
      body: Center(
        child: AnimatedContainer(
          duration: Duration(milliseconds: 500),
          curve: Curves.decelerate,
          width: _width,
          height: _heigth,
          decoration: BoxDecoration(borderRadius: _borderRadius, color: _color),
        ),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: _cambiarContenedor,
        child: Icon(Icons.play_arrow),
      ),
    );
  }

  void _cambiarContenedor() {
    var random = new Random();

    _width = random.nextInt(400).toDouble();
    _heigth = random.nextInt(750).toDouble();
    _color = Color.fromRGBO(
        random.nextInt(255), random.nextInt(255), random.nextInt(255), 1);
    setState(() {});
  }
}
