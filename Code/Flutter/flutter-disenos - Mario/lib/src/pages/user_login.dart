import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class Login extends StatelessWidget {
  static Color mycolor = Colors.red;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: PageView(
      scrollDirection: Axis.vertical,
      children: <Widget>[_pagina1(), _pagina2(context)],
    ));
  }

  Widget _pagina1() {
    return Stack(
      children: <Widget>[
        _colorFondo(),
        _imagenFondo(),
        _textos(),
      ],
    );
  }

  Widget _colorFondo() {
    return Container(
      width: double.infinity,
      height: double.infinity,
      color: Color.fromRGBO(108, 192, 218, 1.0),
    );
  }

  Widget _imagenFondo() {
    return Container(
      width: double.infinity,
      height: double.infinity,
      child: Image(
        image: AssetImage('assets/loginimage.jpg'),
        fit: BoxFit.cover,
      ),
    );
  }

  Widget _textos() {
    final estiloTexto = TextStyle(color: Colors.white, fontSize: 50.0);
    DateFormat dateFormat = DateFormat("dd-MM-yyyy");
    String datetime = dateFormat.format(DateTime.now());

    return SafeArea(
      child: Column(
        children: <Widget>[
          Padding(padding: EdgeInsets.only(top: 130.0)),
          SizedBox(height: 20.0),
          Text(datetime, style: estiloTexto),
          Text('Welcome ', style: estiloTexto),
          Expanded(child: Container()),
          Icon(Icons.keyboard_arrow_down, size: 70.0, color: Colors.white)
        ],
      ),
    );
  }

  Widget _pagina2(BuildContext context) {
    return Container(
      color: mycolor,
      width: 25,
      height: 50,
      padding: EdgeInsetsDirectional.only(top: 100),
      child: Column(
        children: [
          _crearcontenedor(context),
        ],
      ),
    );
  }

  Widget _crearcontenedor(BuildContext context) {
    return Container(
      color: mycolor,
      child: Center(
        child: Column(
          children: [
            _crearEmail(),
            Divider(),
            _crearPassword(),
            Divider(),
            _crearBoton(context)
          ],
        ),
      ),
    );
  }

  Widget _crearBoton(BuildContext context) {
    return RaisedButton(
      shape: StadiumBorder(),
      color: Colors.blue,
      textColor: Colors.white,
      child: Padding(
        padding: EdgeInsets.symmetric(horizontal: 40.0, vertical: 20.0),
        child: Text('Bienvenidos', style: TextStyle(fontSize: 20.0)),
      ),
      onPressed: () => Navigator.pushNamed(context, 'botones'),
    );
  }

  Widget _crearEmail() {
    return TextField(
      keyboardType: TextInputType.emailAddress,
      decoration: InputDecoration(
        border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
        hintText: 'email',
        labelText: 'email',
        suffixIcon: Icon(Icons.alternate_email),
        icon: Icon(Icons.email),
      ),
    );
  }

  Widget _crearPassword() {
    return TextField(
      obscureText: true,
      keyboardType: TextInputType.emailAddress,
      decoration: InputDecoration(
        border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
        hintText: 'Password',
        labelText: 'Password',
        suffixIcon: Icon(Icons.lock_open),
        icon: Icon(Icons.lock),
      ),
    );
  }
}
