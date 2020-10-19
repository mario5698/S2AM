import 'poke_model.dart';
import 'poke_detail_page.dart';
import 'package:flutter/material.dart';

class PokeCard extends StatefulWidget {
  PokeCard({this.pokemon, this.localIndex, this.pokemons, this.callback});

  final Pokemon pokemon;
  final List<Pokemon> pokemons;
  int localIndex;

  Function callback;

  @override
  _PokeCardState createState() => _PokeCardState(pokemon);
}

class _PokeCardState extends State<PokeCard> {

  var AvatarImage;
  Pokemon pokemon;
  String renderUrl;

  _PokeCardState(this.pokemon);

  void initState() {
    super.initState();
    renderPokePic();
  }

  Widget get pokeImage {
    var pokeAvatar = new Hero(
      tag: pokemon,
      child: new Container(
        width: 100.0,
        height: 100.0,
        child: Image.network(widget.pokemon.imageUrl ?? ''),
        
        decoration: new BoxDecoration(color: Colors.transparent)
        
      ),
    );

    var placeholder = new Container(
      width: 100.0,
      height: 100.0,
      decoration: new BoxDecoration(shape: BoxShape.circle),
      alignment: Alignment.center,
      child: new Image.asset("assets/pokeball.png")
    );

    var crossFade = new AnimatedCrossFade(
      firstChild: placeholder,
      secondChild: pokeAvatar,
      crossFadeState: renderUrl == null
          ? CrossFadeState.showFirst
          : CrossFadeState.showSecond,
      duration: new Duration(milliseconds: 1000),
    );

    return crossFade;
  }

  void renderPokePic() async {
    await pokemon.getImageUrl();
    if (mounted) {
      setState(() => renderUrl = pokemon.imageUrl);
    }
  }

  Widget get pokeCard {
    return new Positioned(
      right: 0.0,
      child: new Container(
        //color: Colors.redAccent,
        width: 250,
        height: 115,
        child: new Card(
          color: Colors.redAccent.withOpacity(0.7),
          //color: Colors.transparent,
          //elevation: 0,
          child: new Padding(
            padding: const EdgeInsets.symmetric(vertical: 20),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: <Widget>[
                new Column(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: <Widget>[
                    new Text(widget.pokemon.name.capitalize(), style: TextStyle(color: Colors.white, fontSize: 25)),
                    new Row(
                      children: <Widget>[
                        new Icon(Icons.star, color: Colors.amber),
                        new Text(' ${widget.pokemon.rating}/10', style: TextStyle(color: Colors.white))
                      ],
                    ),
                  ],
                ),
                Container(
                  width: 50,
                  child: IconButton(
                    icon: Icon(Icons.clear, size: 50, color: Colors.white),
                    onPressed: () {
                      widget.pokemons.removeAt(widget.localIndex);
                      this.widget.callback(widget.pokemons);
                    },
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  showPokeDetailPage() async {
    await Navigator.of(context).push(MaterialPageRoute(builder: (context) {
      return new PokeDetailPage(pokemon);
    }));
    setState(() {
      
    });
  }

  @override
  Widget build(BuildContext context) {
    return new InkWell(
      onTap: () {
        showPokeDetailPage();
      },
      child: new Padding(
        padding: const EdgeInsets.symmetric(horizontal: 16.0, vertical: 8.0),
        child: new Container(
          height: 115.0,
          child: new Stack(
            children: <Widget>[
              pokeCard,
              new Positioned(top: 7.5, child: pokeImage),
            ],
          ),
        ),
      ),
    );
  }
}
