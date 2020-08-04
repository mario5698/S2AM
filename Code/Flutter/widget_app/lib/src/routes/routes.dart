import 'package:flutter/material.dart';
import 'package:widget_app/src/pages/Home_Page.dart';
import 'package:widget_app/src/pages/alert_page.dart';
import 'package:widget_app/src/pages/avatar_page.dart';
import 'package:widget_app/src/pages/card_page.dart';

Map<String, WidgetBuilder> getApplicationsRoutes() {
  return <String, WidgetBuilder>{
    '/': (BuildContext context) => HomePAge(),
    'alert': (BuildContext context) => AlertPage(),
    'avatar': (BuildContext context) => AvatarPage(),
    'card': (BuildContext context) => CardPage(),
  };
}
