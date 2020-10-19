import 'package:flutter/material.dart';
import 'poke_model.dart';
import 'dart:async';

class PokeDetailPage extends StatefulWidget {
  final Pokemon pokemon;
  PokeDetailPage(this.pokemon);

  @override
  _PokeDetailPageState createState() => new _PokeDetailPageState();
}

class _PokeDetailPageState extends State<PokeDetailPage> {

  var AvatarImage;
  final double pokeAvarterSize = 150.0;
  double _sliderValue;

  @override
  void initState() {
    super.initState();
    _sliderValue = widget.pokemon.rating.toDouble();
    AvatarImage = widget.pokemon.correct ? NetworkImage(widget.pokemon.imageUrl) : AssetImage("assets/pokeball.png");
  }
  
  Widget get addYourRating {
    return new Column(
      children: <Widget>[
        new Container(
          padding: new EdgeInsets.symmetric(vertical: 16.0, horizontal: 16.0),
          child: new Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: <Widget>[
              new Flexible(
                flex: 1,
                child: new Slider(
                  activeColor: Colors.red,
                  min: 0.0,
                  max: 10.0,
                  value: _sliderValue,
                  onChanged: (newRating) {
                    setState(() => _sliderValue = newRating);
                  },
                ),
              ),
              new Container(
                width: 50.0,
                alignment: Alignment.center,
                child: new Text('${_sliderValue.toInt()}',
                    style: TextStyle(color: Colors.red, fontSize: 30)),
              ),
            ],
          ),
        ),
        submitRatingButton,
      ],
    );
  }

  void updateRating() {
    if (_sliderValue < 5) _ratingErrorDialog();
    setState(() => widget.pokemon.rating = _sliderValue.toInt());
  }

  Future<Null> _ratingErrorDialog() async {
    return showDialog(
      context: context,
      builder: (BuildContext context) {
        return new AlertDialog(
          title: new Text('Watchout!'),
          content: new Text("${widget.pokemon.name} will be sad :C"),
          actions: <Widget>[
            new FlatButton(
              child: new Text('Try Again'),
              onPressed: () => Navigator.of(context).pop(),
            )
          ],
        );
      }
    );
  }

  Widget get submitRatingButton {
    return new RaisedButton(
      padding: EdgeInsets.symmetric(horizontal: 40, vertical: 15),
      onPressed: () => updateRating(),
      child: new Text('Rate', style: TextStyle(fontSize: 20),),
      color: Colors.red,
    );
  }

  Widget get pokeImage {
    return new Hero(
      tag: widget.pokemon,
      child: new Container(
        height: pokeAvarterSize,
        width: pokeAvarterSize,
        constraints: new BoxConstraints(),
        decoration: new BoxDecoration(
            //shape: BoxShape.circle,
            image: new DecorationImage(
              fit: BoxFit.cover,
              image: AvatarImage,
            )
          ),
      ),
    );
  }

  Widget get rating {
    return new Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: <Widget>[
        new Icon(
          Icons.star,
          size: 40.0,
          color: Colors.amber,
        ),
        new Text(
          '${widget.pokemon.rating}/10',
          style: TextStyle(color: Colors.white, fontSize: 30)
        )
      ],
    );
  }

  Widget get pokeType {

    if (!widget.pokemon.correct) {
      return Tooltip (
        message: "Unknown",
        child: Container(width: 75, child: Image.asset("assets/unknown.png"))
      );
    }

    else if (widget.pokemon.types.length == 1) {
      return Tooltip(
        message: widget.pokemon.firstType.capitalize(),
        child: Container(width: 75, child: Image.asset("assets/${widget.pokemon.firstType}.png"))
      );
    }
    
    else {
      return Row(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        children: <Widget>[
          Tooltip (
            message: widget.pokemon.firstType.capitalize(),
            child: Container(width: 75, child: Image.asset("assets/${widget.pokemon.firstType}.png"))
          ),
          Tooltip (
            message: widget.pokemon.secondType.capitalize(),
            child: Container(width: 75, child: Image.asset("assets/${widget.pokemon.secondType}.png"))
          )
        ],
      );
    }
  }

  Widget get pokeStats {
    /*
    return Table(
      border: TableBorder.all(),
      children: [
        TableRow(
          children: <Widget>[
            Text("HP", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("Att", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("Def", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("S. Att", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("S. Def", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("Spd", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
          ]
        ),
        TableRow(
          children: <Widget>[
            Text("${widget.pokemon.hp}", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("${widget.pokemon.attack}", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("${widget.pokemon.defense}", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("${widget.pokemon.specialAttack}", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("${widget.pokemon.specialDefense}", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
            Text("${widget.pokemon.speed}", style: TextStyle(color: Colors.redAccent, fontSize: 20), textAlign: TextAlign.center),
          ]
        ),
      ],
    );
    */
    return Container(
      padding: EdgeInsets.all(16),
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: <Widget>[
              Card(
                color: Colors.redAccent,
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: Text("HP: ${widget.pokemon.hp}", style: TextStyle(fontSize: 15)),
                ),
              ),
              Card(
                color: Colors.redAccent,
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: Text("Att: ${widget.pokemon.attack}", style: TextStyle(fontSize: 15)),
                ),
              ),
              Card(
                color: Colors.redAccent,
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: Text("Def: ${widget.pokemon.defense}", style: TextStyle(fontSize: 15)),
                ),
              ),
            ],
          ),
          SizedBox(height: 10),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: <Widget>[
              Card(
                color: Colors.redAccent,
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: Text("S. Att: ${widget.pokemon.specialAttack}", style: TextStyle(fontSize: 15,)),
                ),
              ),
              Card(
                color: Colors.redAccent,
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: Text("S. Def: ${widget.pokemon.specialDefense}", style: TextStyle(fontSize: 15)),
                ),
              ),
              Card(
                color: Colors.redAccent,
                child: Padding(
                  padding: const EdgeInsets.all(8.0),
                  child: Text("Speed: ${widget.pokemon.speed}", style: TextStyle(fontSize: 15)),
                ),
              ),
            ],
          ),
        ],
      )
    );
    
  }

  Widget get pokeProfile {
    return new Container(
      padding: new EdgeInsets.symmetric(vertical: 32.0),
      decoration: new BoxDecoration(
        image: DecorationImage(
          fit: BoxFit.cover,
          image: AssetImage("assets/cave.jpg"),
          colorFilter: ColorFilter.mode(Colors.green, BlendMode.darken)
        ),
      ),
      child: new Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        children: <Widget>[
          pokeImage,
          rating,
          new Text(
            '${widget.pokemon.name.capitalize()}',
            style: TextStyle(fontSize: 50.0, color: Colors.white),
            
          ),
          pokeType,
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return new Scaffold(
      backgroundColor: Colors.white,
      appBar: new AppBar(
        backgroundColor: Colors.red,
        title: new Text('${widget.pokemon.name.capitalize()}', style: TextStyle(color: Colors.white)),
      ),
      body: new ListView(
        children: <Widget>[pokeProfile, pokeStats, addYourRating],
      ),
    );
  }
}
