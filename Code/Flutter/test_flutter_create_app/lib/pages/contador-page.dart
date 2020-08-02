import 'package:flutter/material.dart';

class ContadorPage extends StatefulWidget {
  @override
  createState() => _ContadorPageState();
}

class _ContadorPageState extends State<ContadorPage> {
  final _textstyle = TextStyle(fontSize: 25);
  var _contador = 0;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Test exercise flutter'),
        centerTitle: true,
      ),
      body: Center(
          child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          Text(
            'Numero de Clicks',
            style: _textstyle,
          ),
          Text(
            '$_contador',
            style: _textstyle,
          ),
        ],
      )),
      floatingActionButton: _crearBotones(),
    );
  }

  Widget _crearBotones() {
    return Row(
      children: <Widget>[
        SizedBox(
          width: 30,
        ),
        FloatingActionButton(
          child: Icon(Icons.exposure_zero),
          onPressed: _iniciar,
        ),
        FloatingActionButton(
            child: Text(
              '100',
              style: _textstyle,
            ),
            onPressed: _uP100),
        Expanded(
          child: SizedBox(),
        ),
        FloatingActionButton(
          child: Icon(Icons.remove),
          onPressed: _restar,
        ),
        SizedBox(
          width: 5.0,
        ),
        FloatingActionButton(
          child: Icon(Icons.add),
          onPressed: _sumar,
        ),
      ],
    );
  }

  void _uP100() => setState(() => _contador = 100);

  void _sumar() => setState(() => _contador++);

  void _restar() => setState(() => _contador--);

  void _iniciar() => setState(() => _contador = 0);
}
