import 'package:flutter/material.dart';
import 'dart:async';
import 'poke_model.dart';
import 'poke_list.dart';
import 'new_poke_form.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'PokeRater',
      theme: ThemeData(brightness: Brightness.dark),
      home: MyHomePage(
        title: 'PokeRater',
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

  List<Pokemon> pokemons = []
    ..add(Pokemon("rayquaza"))
    ..add(Pokemon("pikachu"))
    ..add(Pokemon("fletchinder"))
    ..add(Pokemon("groudon"))
    ..add(Pokemon("charizard"))
    ..add(Pokemon("Agumon"))
    ..add(Pokemon("zamazenta"));

  Future _showNewPokeForm() async {
    Pokemon newPokemon = await Navigator.of(context)
      .push(MaterialPageRoute(builder: (BuildContext context) {
      return AddPokeFormPage();
    }));
    print(newPokemon);
    if (newPokemon != null) pokemons.add(newPokemon);
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    var key = new GlobalKey<ScaffoldState>();
    return new Scaffold(
      key: key,
      appBar: new AppBar(
        title: new Text(widget.title, style: TextStyle(color: Colors.white),),
        backgroundColor: Colors.red,
        actions: <Widget>[
          new IconButton(
            icon: new Icon(Icons.add, color: Colors.white,),
            onPressed: _showNewPokeForm,
          ),
        ],
      ),
      body: new Container(
        decoration: new BoxDecoration(image: DecorationImage(
          image: AssetImage("assets/background.jpg"),
          fit: BoxFit.cover,
        ),),
        child: new Center(
          child: PokeList(pokemons, updatePokemons)
        )),
    );
  }

  void updatePokemons(List<Pokemon> newPokemons) {
    setState(() {
      pokemons = newPokemons;
    });
  }
}
