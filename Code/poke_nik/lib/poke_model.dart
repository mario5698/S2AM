import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:http/http.dart' as http;
import 'package:poke/types_model.dart';

extension StringExtension on String {
  String capitalize() => "${this[0].toUpperCase()}${this.substring(1)}";
}

class Pokemon {
  String name;
  int id;

  List<dynamic> types;
  String firstType;
  String secondType;

  int hp;
  int attack;
  int defense;
  int specialAttack;
  int specialDefense;
  int speed;

  String technicalName;
  String description;
  String imageUrl;

  int rating = 10;
  bool correct = true;
  bool imgCorrect = true;

  Pokemon(this.name);

  fromJson(Map<String, dynamic> json) {
    id = json["id"];
    name = json["name"];
    
    types = json["types"];
    firstType = types[0]["type"]["name"];
    secondType = types.length == 2 ? types[1]["type"]["name"] : "N/A";

    hp = json["stats"][0]["base_stat"];
    attack = json["stats"][1]["base_stat"];
    defense = json["stats"][2]["base_stat"];
    specialAttack = json["stats"][3]["base_stat"];
    specialDefense = json["stats"][4]["base_stat"];
    speed = json["stats"][5]["base_stat"];
  }

  Future getImageUrl() async {
    if (imageUrl != null) return;

    try {
      dynamic response = await fetchPokemon(name);
      if (correct) await fromJson(response);
      await fetchImage();
    } catch (exception) {
      print(exception);
    }
  }

  Future fetchPokemon(String name) async {
    technicalName = name.toLowerCase();
    final response = await http.get("https://pokeapi.co/api/v2/pokemon/$technicalName");

    if (response.statusCode != 200) {
      correct = false;
      throw Exception('Failed to load $name');
    }

    return json.decode(response.body);
  }

  Future fetchImage() async {
    //final imgResponse = await http.get("https://img.pokemondb.net/sprites/home/normal/$technicalName.png");
    final imgResponse = await http.get("https://pokeres.bastionbot.org/images/pokemon/$id.png");    

    if (imgResponse.statusCode == 200) {
      //imageUrl = "https://img.pokemondb.net/sprites/home/normal/$technicalName.png";
      imageUrl = "https://pokeres.bastionbot.org/images/pokemon/$id.png";
    } else {
      imageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/$id.png";
      imgCorrect = false;
      throw Exception('Failed to load image for $technicalName');
    }
  }
}
