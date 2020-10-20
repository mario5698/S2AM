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

//añadir url de busqueda
class _MyHomePageState extends State<MyHomePage> {
  List<Dog> initialDoggos = []
    ..add(Dog(
        'Bender',
        'Portland, OR, USA',
        'Ruby is a very good girl. Yes: Fetch, loungin\'. No: Dogs who get on furniture.',
        'https://vignette.wikia.nocookie.net/esfuturama/images/9/91/Bender_Bending_Rodr%C3%ADguez.png/revision/latest?cb=20130615070942'))
    ..add(Dog('philips', 'Seattle, WA, USA', 'Best in Show 1999',
        'https://vignette.wikia.nocookie.net/esfuturama/images/f/f2/PhilipJ.Fry.png/revision/latest?cb=20120825055147'))
    ..add(Dog(
        'homer ',
        'Prague, CZ',
        'Star good boy on international snooze team.',
        'https://www.grupoblc.com/wp-content/uploads/2013/10/images_curiosita_homer.jpg'))
    ..add(Dog('Bart', 'Dallas, TX, USA', 'A Very Good Boy',
        'https://img.discogs.com/BxXiv86dhWeXnfPl4eyGU37a92U=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/A-1010823-1335728016.png.jpg'))
    ..add(Dog('image random ', 'North Pole, Earth', 'Self proclaimed human lover.', 'https://picsum.photos/200/300?random=2'));

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
                Colors.red,
                Colors.pink[300],
                Colors.indigo[600],
                Colors.blue
              ])),
          child: new Center(
            child: new DogList(initialDoggos),
          )),
    );
  }
}
