import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:sqlite_and_mock/pages/home_page.dart';
//import 'package:sqlite_and_mock/pages/mock/mock_page.dart';
//import 'package:sqlite_and_mock/pages/sqlite/sqlite_page.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle.light
        .copyWith(statusBarColor: Colors.transparent));
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'sqlite and mock',
      initialRoute: 'home',
      routes: {
        'home': (BuildContext context) => Home_page(),
        // 'mock': (BuildContext context) => Mock_Page(),
        //'sqlite': (BuildContext context) => Sqlite_Page(),
        //'home': (BuildContext context) => MyHomePage(),
      },
    );
  }
}
