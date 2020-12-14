import 'package:flutter/material.dart';

class SqlitePage extends StatelessWidget {
  const SqlitePage({Key key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Sqlite Page'),
      ),
      body: Center(
        child: Container(
          child: Column(
            children: [
              Text('Sqlite page'),
            ],
          ),
        ),
      ),
    );
  }
}
