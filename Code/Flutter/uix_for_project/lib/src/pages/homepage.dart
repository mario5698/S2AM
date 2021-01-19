import 'package:flutter/material.dart';
import 'package:uix_for_project/src/widgets/headers.dart';

class HomePage extends StatelessWidget {
  const HomePage({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: HeaderCurvo2Gradient(),
    );
  }
}
