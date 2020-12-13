import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class BasicoPage extends StatefulWidget {
  BasicoPage({Key key}) : super(key: key);

  @override
  _BasicoPageState createState() => _BasicoPageState();
}

class _BasicoPageState extends State<BasicoPage> {
  final estiloTitulo = TextStyle(fontSize: 20.0, fontWeight: FontWeight.bold);
  final estiloSubTitulo = TextStyle(fontSize: 18.0, color: Colors.white);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        color: Color.fromRGBO(255, 66, 107, 0.7),
        child: Column(
          children: <Widget>[
            _crearImagen(context),
            _crearTitulo(),
            _crearAcciones(),
            _crearTexto(),
          ],
        ),
      ),
    );
  }

  Widget _crearImagen(BuildContext context) {
    return Container(
      width: double.infinity,
      child: GestureDetector(
        onTap: () => Navigator.pushNamed(context, 'botones'),
        child: Image(
          image: NetworkImage(
              'https://images.pexels.com/photos/814499/pexels-photo-814499.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500'),
          height: 200.0,
          fit: BoxFit.cover,
        ),
      ),
    );
  }

  Widget _crearTitulo() {
    return SafeArea(
      child: Container(
        padding: EdgeInsets.symmetric(horizontal: 30.0, vertical: 20.0),
        child: Row(
          children: <Widget>[
            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: <Widget>[
                  Text('Lago con un puente', style: estiloTitulo),
                  SizedBox(height: 7.0),
                  Text('Un lago en Alemania', style: estiloSubTitulo),
                ],
              ),
            ),
            Icon(Icons.star, color: Colors.red, size: 30.0),
            Text('41', style: TextStyle(fontSize: 20.0))
          ],
        ),
      ),
    );
  }

  Widget _crearAcciones() {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
      children: <Widget>[
        _accion(Icons.call, 'CALL'),
        _accion(Icons.near_me, 'ROUTE'),
        _accion(Icons.share, 'Share'),
      ],
    );
  }

  Widget _accion(IconData icon, String texto) {
    return RaisedButton(
      color: Color.fromRGBO(62, 66, 107, 0.7).withOpacity(0.5),
      child: Column(
        children: [
          Icon(icon, color: Colors.red, size: 40.0),
          SizedBox(height: 5.0),
          Text(
            texto,
            style: TextStyle(fontSize: 15.0, color: Colors.blue[100]),
          ),
        ],
      ),
      onPressed: () => Navigator.pushNamed(context, 'botones'),
    );
  }

  Widget _crearTexto() {
    return SafeArea(
      child: Container(
        padding: EdgeInsets.symmetric(horizontal: 40.0),
        child: Text(
          'Sit minim aliqua minim laborum duis occaecat consectetur aliquip id ad deserunt. Adipisicing qui reprehenderit eu eu qui occaecat exercitation et aliqua laboris dolor. Nisi duis consectetur veniam id nulla deserunt aliqua velit ullamco. Deserunt exercitation adipisicing nostrud amet eu.',
          textAlign: TextAlign.justify,
          style: TextStyle(fontSize: 15.0, color: Colors.blue[50]),
        ),
      ),
    );
  }
}
