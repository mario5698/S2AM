import 'package:flutter/material.dart';
import 'poke_card.dart';
import 'poke_model.dart';

class PokeList extends StatefulWidget {
  PokeList(this.pokemons, this.mainCallback);
  List<Pokemon> pokemons;
  final Function mainCallback;

  @override
  _PokeListState createState() => _PokeListState();
}

class _PokeListState extends State<PokeList> {
  @override
  Widget build(BuildContext context) {
    return ListView.builder(
      itemCount: widget.pokemons.length,
      itemBuilder: (context, int index) {
        return PokeCard(pokemon: widget.pokemons[index], localIndex: index, pokemons: widget.pokemons, callback: callback);
      },
    );
  }

  void callback(List<Pokemon> newPokemons) {
    setState(() {
      widget.mainCallback(newPokemons);
    });
  }
}