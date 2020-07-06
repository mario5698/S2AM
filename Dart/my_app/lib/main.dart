import 'package:flutter/material.dart';
import 'package:my_app/tabs/inicio_tabs.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    final TabController = new DefaultTabController(
      length: 5, //numero iconos  de barra
      child: new Scaffold(
        appBar: new AppBar(
          title: new Text('navegacion por Tabs'),
          bottom: new TabBar(
            indicatorColor: Colors.red,
            tabs: <Widget>[
              new Tab(icon: new Icon(Icons.home), text: 'inicio'),
              new Tab(icon: new Icon(Icons.contacts), text: 'registro'),
              new Tab(icon: new Icon(Icons.place), text: 'lugares'),
              new Tab(icon: new Icon(Icons.help), text: 'ayuda'),
            ],
          ),
        ),

body: new TabBarView(
  children: <Widget>[
new inicioTabs (),
  ],
),

      ),
    );
    return new MaterialApp(
      title: 'Tabs con Flutter ',
    theme: new ThemeData(
primarySwatch: Colors.blue,
    )
  home: TabController,
    )
  }
}
