import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:sql_mock_entrega/pages/Home_page.dart';
import 'package:sql_mock_entrega/pages/Sqlite/page/Sqlite_page.dart';
import 'package:sql_mock_entrega/pages/Mock/Mock_page.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle.light
        .copyWith(statusBarColor: Colors.transparent));
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'sqlite and mock',
      initialRoute: 'Home',
      routes: {
        'Home': (BuildContext context) => HomePage(),
        'Sqlite': (BuildContext context) => SqlitePage(),
        'Mock': (BuildContext context) => MockPage(),
      },
    );
  }
}
