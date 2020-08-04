import 'package:flutter/material.dart';
import 'package:widget_app/src/pages/alert_page.dart';
import 'package:widget_app/src/routes/routes.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'Componentes APP',
        debugShowCheckedModeBanner: false,
        // home: HomePAge(),
        initialRoute: '/',
        routes: getApplicationsRoutes(),
        onGenerateRoute: (RouteSettings settings) {
          print('ruta llamada: ${settings.name}');

          return MaterialPageRoute(
              builder: (BuildContext context) => AlertPage());
        });
  }
}
