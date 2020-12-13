import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:disenos/src/pages/basico_page.dart';
import 'package:disenos/src/pages/botones_page.dart';
import 'package:disenos/src/pages/user_login.dart';
import 'package:disenos/src/pages/rainbow.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle.light
        .copyWith(statusBarColor: Colors.transparent));
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Diseños',
      initialRoute: 'login',
      routes: {
        'basico': (BuildContext context) => BasicoPage(),
        'botones': (BuildContext context) => BotonesPage(),
        'login': (BuildContext context) => Login(),
        //'home': (BuildContext context) => MyHomePage(),
      },
    );
  }
}
