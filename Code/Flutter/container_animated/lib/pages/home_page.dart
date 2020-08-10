import 'package:flutter/material.dart';
import 'dart:math';

class HomePage extends StatefulWidget {
  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  double _width = 50.0;
  double _heigth = 50.0;
  Color _color = Colors.pink;
  BorderRadiusGeometry _borderRadius = BorderRadius.circular(8.0);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Animated Container Page'),
      ),
      body: Center(
        child: AnimatedContainer(
          duration: Duration(milliseconds: 500),
          width: _width,
          height: _heigth,
          decoration: BoxDecoration(borderRadius: _borderRadius, color: _color),
        ),
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: _variarTamao,
        child: Icon(Icons.play_arrow),
      ),
    );
  }

  void _variarTamao() {
    var _random = new Random();

    _width = _random.nextInt(400).toDouble();
    _heigth = _random.nextInt(750).toDouble();
    _color = Color.fromRGBO(
        _random.nextInt(255), _random.nextInt(255), _random.nextInt(255), 1);
    setState(() {});
  }
}
