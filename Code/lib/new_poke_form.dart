import 'poke_model.dart';
import 'package:flutter/material.dart';

class AddPokeFormPage extends StatefulWidget {
  @override
  _AddPokeFormPageState createState() => new _AddPokeFormPageState();
}

class _AddPokeFormPageState extends State<AddPokeFormPage> {
  TextEditingController nameController = new TextEditingController();
  FocusNode focus = new FocusNode();

  void updateFocus() {
    setState(() => FocusScope.of(context).requestFocus(focus));
  }

  void submitPokemon(BuildContext context) {
    if (nameController.text.isEmpty) {
      Scaffold.of(context).showSnackBar(
        new SnackBar(
          backgroundColor: Colors.redAccent,
          content: new Text('Pokemons neeed names!')
        )
      );
    } else {
      var newPokemon = new Pokemon(nameController.text);
      Navigator.of(context).pop(newPokemon);
    }
  }

  @override
  Widget build(BuildContext context) {
    return new Scaffold(
      appBar: new AppBar(
        title: new Text('Add a new Pokemon', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.red,
      ),
      body: new Container(
        decoration: new BoxDecoration(
          image: DecorationImage(image: AssetImage("assets/background.jpg"), fit: BoxFit.cover)),
        child: new Padding(
          padding: const EdgeInsets.symmetric(vertical: 8.0, horizontal: 32.0),
          child: new Column(children: [
            new Padding(
              padding: const EdgeInsets.only(bottom: 8.0),
              child: new TextField(
                onTap: updateFocus,
                focusNode: focus,
                controller: nameController,
                decoration: new InputDecoration(
                  fillColor: Colors.redAccent,
                  //enabledBorder: const UnderlineInputBorder(borderSide: const BorderSide(color: Colors.red, width: 2.0)),
                  focusedBorder: const UnderlineInputBorder(borderSide: const BorderSide(color: Colors.red, width: 2.0)),
                  labelText: 'Name / ID',
                  labelStyle: TextStyle(color: focus.hasFocus ? Colors.red : Colors.white)
                ),
                style: TextStyle(color: Colors.red),
              ),
            ),
            new Padding(
              padding: const EdgeInsets.all(16.0),
              child: new Builder(
                builder: (context) {
                  return new RaisedButton(
                    onPressed: () => submitPokemon(context),
                    color: Colors.redAccent,
                    child: new Text('Add Pokemon', style: TextStyle(color: Colors.white),
                    ),
                  );
                },
              ),
            )
          ]),
        ),
      ),
    );
  }
}
