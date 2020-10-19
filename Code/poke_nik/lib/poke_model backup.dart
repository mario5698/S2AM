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
  String technicalName;
  String description;
  String imageUrl;
  int id;
  int rating = 10;
  bool correct = true;
  Types types;

  Pokemon(this.name);

  

  fromJson(Map<String, dynamic> json) {
    id = json["id"];
    name = json["name"].toString().capitalize();
    if (correct) {
      types = Types.fromJson(json["types"]);
    }
  }


  Future getImageUrl() async {
    if (imageUrl != null) {
    return;
  }

    HttpClient http = new HttpClient();
    try {
      await fetchPokemon(name);
      if (correct) imageUrl = "https://pokeres.bastionbot.org/images/pokemon/$id.png";
    } catch (exception) {
      print(exception);
    }
  }

  Future fetchPokemon(String name) async {
    technicalName = name.toLowerCase();
    String url = "https://pokeapi.co/api/v2/pokemon/$technicalName";

    final response = await http.get(url);
    var pkmn = Pokemon(name);

    if (response.statusCode == 200) {
    } else {
      correct = false;
      throw Exception('Failed to load pokemon');
    }

    var responseJson = json.decode(response.body);
    print(responseJson);
    print(responseJson["id"]);
    print(responseJson["name"]);
    fromJson(responseJson);

    return pkmn;
  }
}
