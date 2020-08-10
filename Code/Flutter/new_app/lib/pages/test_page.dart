import 'package:flutter/material.dart';

class TestPage extends StatefulWidget {
  @override
  _TestPageState createState() => _TestPageState();
}

class _TestPageState extends State<TestPage> {
  int _numero = 0;
  TextStyle _estilo = TextStyle(fontSize: 30);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Test page contador'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              'Numero de clicks',
              style: _estilo,
            ),
            Text(
              '$_numero',
              style: _estilo,
            ),
          ],
        ),
      ),
      floatingActionButton: _crearBotones(),
    );
  }

  Widget _crearBotones() {
    return Row(
      children: [
        SizedBox(
          width: 100.0,
        ),
        FloatingActionButton(
          onPressed: _sumar,
          child: Icon(Icons.add),
        ),
        SizedBox(
          width: 30.0,
        ),
        FloatingActionButton(
          onPressed: _restar,
          child: Icon(Icons.remove),
        ),
        SizedBox(
          width: 30.0,
        ),
        FloatingActionButton(
          onPressed: _toZero,
          child: Icon(Icons.exposure_zero),
        ),
      ],
    );
  }

  void _sumar() {
    _numero++;
    setState(() {});
  }

  void _restar() {
    _numero--;
    setState(() {});
  }

  void _toZero() {
    _numero = 0;
    setState(() {});
  }
}
