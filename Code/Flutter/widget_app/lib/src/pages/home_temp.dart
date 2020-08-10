// import 'package:flutter/material.dart';

// class HomePageTemp extends StatelessWidget {
//   final opciones = ['uno', 'dos', 'tres', 'cuatro', 'cinco'];

//   @override
//   Widget build(BuildContext context) {
//     return Scaffold(
//       appBar: AppBar(
//         title: Text('componentes Temp'),
//       ),
//       body: ListView(children: _crearItempsCorto()),
//     );
//   }

//   List<Widget> _crearItems() {
//     List<Widget> lista = new List<Widget>();

//     for (String opt in opciones) {
//       final tempwidget = ListTile(
//         title: Text(opt),
//       );

//       lista
//         ..add(tempwidget)
//         ..add(Divider(
//           color: Colors.black,
//         ));
//     }
//     return lista;
//   }

//   List<Widget> _crearItempsCorto() {
//     return opciones.map((item) {
//       return Column(
//         children: <Widget>[
//           ListTile(
//             leading: Icon(Icons.accessibility),
//             trailing: Icon(Icons.arrow_forward_ios),
//             title: Text(item + '!'),
//             subtitle: Text('data'),
//             onTap: () {
//               print('data');
//             },
//           ),
//           Divider(
//             color: Colors.black,
//           ),
//         ],
//       );
//     }).toList();
//   }
// }
