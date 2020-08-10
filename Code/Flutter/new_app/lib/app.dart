import 'package:flutter/material.dart';
import 'package:new_app/pages/test_page.dart';
// import 'package:new_app/pages/home_page.dart';

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Center(
        child: TestPage(),
      ),
    );
  }
}
