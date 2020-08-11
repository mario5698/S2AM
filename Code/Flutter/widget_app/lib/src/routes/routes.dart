import 'package:flutter/material.dart';
import 'package:widget_app/src/pages/Home_Page.dart';
import 'package:widget_app/src/pages/alert_page.dart';
import 'package:widget_app/src/pages/animater_container.dart';
import 'package:widget_app/src/pages/avatar_page.dart';
import 'package:widget_app/src/pages/card_page.dart';
import 'package:widget_app/src/pages/input_page.dart';
import 'package:widget_app/src/pages/listview_page.dart';
import 'package:widget_app/src/pages/slider_page.dart';

Map<String, WidgetBuilder> getApplicationsRoutes() {
  return <String, WidgetBuilder>{
    '/': (BuildContext context) => HomePAge(),
    'alert': (BuildContext context) => AlertPage(),
    'avatar': (BuildContext context) => AvatarPage(),
    'card': (BuildContext context) => CardPage(),
    'animatedContainer': (BuildContext context) => AnimatedContainerPage(),
    'inputs': (BuildContext context) => InputPage(),
    'slider': (BuildContext context) => SliderPage(),
    'list': (BuildContext context) => ListaPage(),
  };
}
