import 'dart:math';
import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  double _width = 50.0;
  double _height = 50.0;
  int _counter = 500;
  Color _color = Colors.amber;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Animated container'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            AnimatedContainer(
              duration: Duration(milliseconds: _counter),
              width: _width,
              height: _height,
              color: _color,
            ),
          ],
        ),
      ),
      floatingActionButton: FloatingActionButton(
          onPressed: _changeSize,
          child: Icon(
            Icons.all_inclusive,
          )),
    );
  }

  void _changeSize() {
    final _random = new Random();

    _width = _random.nextInt(410).toDouble();
    _height = _random.nextInt(725).toDouble();
    _color = Color.fromARGB(
        _random.nextInt(255), _random.nextInt(255), _random.nextInt(255), 1);
    setState(() {});
  }
}
