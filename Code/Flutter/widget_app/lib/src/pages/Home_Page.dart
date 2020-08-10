import 'package:flutter/material.dart';
// import 'package:widget_app/src/pages/alert_page.dart';
import 'package:widget_app/src/providers/menu_provider.dart';
import 'package:widget_app/src/utils/icono_string_util.dart';

class HomePAge extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Componentes'),
      ),
      body: _lista(),
    );
  }

  Widget _lista() {
    // menuProvider.cargarData()

    return FutureBuilder(
      future: menuProvider.cargarData(),
      initialData: [],
      builder: (context, AsyncSnapshot<List<dynamic>> snapshot) {
        return ListView(
          children: _crearListaItems(snapshot.data, context),
        );
      },
    );
  }

  List<Widget> _crearListaItems(List<dynamic> data, BuildContext context) {
    final List<Widget> opciones = [];
    final colores = Colors.black;
    data.forEach((opt) {
      final widgetTemp = ListTile(
        title: Text(opt['texto']),
        leading: getIcon(opt['icon']),
        trailing: Icon(Icons.keyboard_arrow_right, color: colores),
        onTap: () {
          Navigator.pushNamed(context, opt['ruta']);

          // final route = MaterialPageRoute(builder: (context) => AlertPage());
          // Navigator.push(context, route);
        },
      );

      opciones..add(widgetTemp)..add(Divider());
    });
    return opciones;
  }
}
