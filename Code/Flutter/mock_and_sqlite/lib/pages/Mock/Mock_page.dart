import 'package:flutter/material.dart';

class MockPage extends StatelessWidget {
  const MockPage({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Mock Page'),
      ),
      body: Center(
        child: Container(
          child: Text('Hello mock'),
        ),
      ),
    );
  }
}
