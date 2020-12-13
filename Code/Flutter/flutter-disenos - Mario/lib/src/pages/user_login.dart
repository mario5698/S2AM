import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class Login extends StatefulWidget {
  Login({Key key}) : super(key: key);

  @override
  _LoginState createState() => _LoginState();
}

class _LoginState extends State<Login> {
  static Color mycolor = Colors.white12;
  static Color _textColor = Colors.red;
  final myControllerUser = TextEditingController();
  final myControllerPasswd = TextEditingController();
  @override
  void dispose() {
    myControllerUser.dispose();
    super.dispose();
  }

  void dispose1() {
    myControllerPasswd.dispose();
    super.dispose();
  }

  Widget build(BuildContext context) {
    return SafeArea(
      child: Scaffold(
        body: PageView(
          scrollDirection: Axis.vertical,
          children: <Widget>[_pagina1(), _pagina2(context)],
        ),
      ),
    );
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

  Widget _pagina2(BuildContext context) {
    return Container(
      color: mycolor,
      width: 25,
      height: 50,
      child: Column(
        children: [
          _crearTextLogin(),
          _crearcontenedor(context),
        ],
      ),
    );
  }

  Widget _colorFondo() {
    return Container(
      width: double.infinity,
      height: double.infinity,
      color: Color.fromRGBO(108, 192, 218, 1.0),
    );
  }

  Widget _crearTextLogin() {
    return Container(
      padding: const EdgeInsets.only(top: 10, left: 10, bottom: 10),
      child: Row(
        children: [
          RotatedBox(
            quarterTurns: -1,
            child: Text(
              'Sing in',
              style: TextStyle(
                color: _textColor,
                fontSize: 38,
                fontWeight: FontWeight.w900,
              ),
            ),
          ),
          Text(
            'Lore ipsum',
            style: TextStyle(
              color: _textColor,
              fontSize: 38,
              fontWeight: FontWeight.w900,
            ),
          ),
        ],
      ),
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
          SizedBox(height: 20.0),
          Text(datetime, style: estiloTexto),
          Text('Welcome ', style: estiloTexto),
          Expanded(child: Container()),
          Icon(Icons.keyboard_arrow_down, size: 70.0, color: Colors.white)
        ],
      ),
    );
  }

  Widget _crearcontenedor(BuildContext context) {
    return Container(
      width: double.maxFinite,
      height: 634,
      padding: EdgeInsetsDirectional.only(top: 50),
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

  Widget _crearEmail() {
    return TextField(
      controller: myControllerUser,
      keyboardType: TextInputType.emailAddress,
      decoration: InputDecoration(
        border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
        hintText: 'User',
        labelText: 'User',
        suffixIcon: Icon(Icons.alternate_email),
        icon: Icon(Icons.email),
      ),
    );
  }

  Widget _crearPassword() {
    return TextField(
      controller: myControllerPasswd,
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

  Widget _crearBoton(BuildContext context) {
    return RaisedButton(
      shape: StadiumBorder(),
      color: Colors.blue,
      textColor: Colors.white,
      child: Padding(
        padding: EdgeInsets.symmetric(horizontal: 20.0, vertical: 10.0),
        child: Text('Login', style: TextStyle(fontSize: 20.0)),
      ),
      onPressed: () => Navigator.pushNamed(context, 'basico'),
    );
  }
}
