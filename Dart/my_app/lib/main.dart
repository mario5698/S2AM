import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'Material App',
        home: Scaffold(
            appBar: AppBar(
              title: Text('Material App Bar'),
            ),
            body: Row(children: <Widget>[
              cuadrado(Colors.pink),
              Expanded(child: cuadrado(Colors.green)),
              Expanded(flex: 2, child: cuadrado(Colors.green)),
              cuadrado(Colors.pink),
            ])));
  }
}

class cuadrado extends StatelessWidget {
  final Color color;
  cuadrado(this.color);
  @override
  Widget build(BuildContext context) {
    return Container(
      margin: EdgeInsets.symmetric(vertical: 20, horizontal: 20),
      width: 50.0,
      height: 50.0,
      decoration: BoxDecoration(color: this.color),
    );
  }
}
