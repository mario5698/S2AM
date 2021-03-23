import 'package:flutter/material.dart';

class HomePage extends StatelessWidget {
  const HomePage({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color.fromARGB(255, 130, 161, 177),
      appBar: AppBar(
        title: Text('Sqlite and mock '),
      ),
      body: Center(
        child: Container(
            padding: EdgeInsets.only(top: 250.0),
            child: Column(
              children: [
                _crearBoton(context, 'Sqlite', 'Sqlite'),
                Divider(),
                Divider(),
                _crearBoton(context, 'Mock', 'Mock')
              ],
            )),
      ),
    );
  }

  Widget _crearBoton(BuildContext context, String page, String text) {
    return RaisedButton(
      shape: StadiumBorder(),
      color: Colors.red,
      textColor: Colors.white,
      child: Padding(
        padding: EdgeInsets.symmetric(horizontal: 40.0, vertical: 30.0),
        child: Text(text, style: TextStyle(fontSize: 20.0)),
      ),
      onPressed: () => Navigator.pushNamed(context, page),
    );
  }
}
