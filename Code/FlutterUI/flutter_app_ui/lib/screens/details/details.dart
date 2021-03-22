import 'package:flutter/material.dart';
import 'package:flutter_app_ui/models/product.dart';
import 'package:flutter_svg/flutter_svg.dart';

import '../../constants.dart';
import 'components/body.dart';

class DetailsPage extends StatelessWidget {
  final Product product;
  const DetailsPage({Key key, this.product}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: product.color,
      appBar: buildAppbar(context),
      body: Body(product: product),
    );
  }

  AppBar buildAppbar(BuildContext context) {
    return AppBar(
      backgroundColor: product.color,
      elevation: 0,
      leading: IconButton(
        icon: SvgPicture.asset(
          "assets/icons/back.svg",
          color: Colors.yellow,
        ),
        onPressed: () => Navigator.pop(context),
      ),
      actions: <Widget>[
        IconButton(
          icon: SvgPicture.asset(
            "assets/icons/search.svg",
          ),
          onPressed: null,
        ),
        IconButton(
          icon: SvgPicture.asset(
            "assets/icons/cart.svg",
          ),
          onPressed: null,
        ),
        SizedBox(
          width: kDefaultPaddin / 2,
        ),
      ],
    );
  }
}
