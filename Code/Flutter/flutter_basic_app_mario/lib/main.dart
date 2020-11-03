import 'package:flutter/material.dart';
import 'dart:async';

import 'dog_model.dart';
import 'dog_list.dart';
import 'new_dog_form.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'We Rate Dogs',
      theme: ThemeData(brightness: Brightness.dark),
      home: MyHomePage(
        title: 'We Rate Dogs',
      ),
    );
  }
}

class MyHomePage extends StatefulWidget {
  final String title;
  MyHomePage({Key key, this.title}) : super(key: key);

  @override
  _MyHomePageState createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  List<Dog> initialDoggos = []
    ..add(Dog(
        'Bart',
        'Portland, OR, USA',
        'Ruby is a very good girl. Yes: Fetch, loungin\'. No: Dogs who get on furniture.',
        'https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png'))
    ..add(Dog('Bender', 'Seattle, WA, USA', 'Best in Show 1999',
        'https://upload.wikimedia.org/wikipedia/en/a/a6/Bender_Rodriguez.png'))
    ..add(Dog(
        'Marge',
        'Prague, CZ',
        'Star good boy on international snooze team.',
        'https://upload.wikimedia.org/wikipedia/en/0/0b/Marge_Simpson.png'))
    ..add(Dog('leela', 'Dallas, TX, USA', 'A Very Good Boy',
        'https://cdn.pixabay.com/photo/2018/10/19/06/21/turanga-leela-3757930_960_720.png'))
    ..add(Dog('maggie', 'North Pole, Earth', 'Self proclaimed human lover.', 'https://vignette.wikia.nocookie.net/lossimpson/images/9/9d/Maggie_Simpson.png/revision/latest?cb=20100529224628&path-prefix=es'));

  Future _showNewDogForm() async {
    Dog newDog = await Navigator.of(context)
        .push(MaterialPageRoute(builder: (BuildContext context) {
      return AddDogFormPage();
    }));
    if (newDog != null) {
      initialDoggos.add(newDog);
    }
  }

  @override
  Widget build(BuildContext context) {
    var key = new GlobalKey<ScaffoldState>();
    return new Scaffold(
      key: key,
      appBar: new AppBar(
        title: new Text(widget.title),
        backgroundColor: Colors.black87,
        actions: <Widget>[
          new IconButton(
            icon: new Icon(Icons.add),
            onPressed: _showNewDogForm,
          ),
        ],
      ),
      body: new Container(
          decoration: new BoxDecoration(
              gradient: new LinearGradient(
                  begin: Alignment.topRight,
                  end: Alignment.bottomLeft,
                  stops: [
                .1,
                .5,
                .7,
                .9
              ],
                  colors: [
                Colors.indigo[800],
                Colors.indigo[700],
                Colors.indigo[600],
                Colors.indigo[400]
              ])),
          child: new Center(
            child: new DogList(initialDoggos),
          )),
    );
  }
}
