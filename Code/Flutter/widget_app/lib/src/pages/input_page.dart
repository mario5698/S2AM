import 'package:flutter/material.dart';

class InputPage extends StatefulWidget {
  @override
  _InputPageState createState() => _InputPageState();
}

class _InputPageState extends State<InputPage> {
  String _nombre = '';
  String _email = '';
  String _fecha = '';
  String _opcionSelecionada = 'volar';

  List<String> _poderes = ['volar', 'rayos X', 'super aliento', 'super fuerza'];

  TextEditingController _inputfieldDateControler = new TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('InputPage'),
      ),
      body: ListView(
        padding: EdgeInsets.symmetric(horizontal: 10.0, vertical: 20.0),
        children: [
          _crearInput(),
          Divider(),
          _crearEmail(),
          Divider(),
          _crearPassword(),
          Divider(),
          _crearFecha(context),
          Divider(),
          _crearDropdown(),
          Divider(),
          _crearpersona(),
        ],
      ),
    );
  }

  Widget _crearInput() {
    return TextField(
      // autofocus: true,
      textCapitalization: TextCapitalization.sentences,
      decoration: InputDecoration(
        border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
        counter: Text('letra  ${_nombre.length}'),
        hintText: 'nombre de la persona',
        labelText: 'nombre',
        helperText: 'Solo es el nombre',
        suffixIcon: Icon(Icons.accessibility_new),
        icon: Icon(Icons.account_circle),
      ),
      onChanged: (valor) {
        _nombre = valor;
        setState(() {});
      },
    );
  }

  Widget _crearEmail() {
    return TextField(
      keyboardType: TextInputType.emailAddress,
      decoration: InputDecoration(
        border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
        hintText: 'email',
        labelText: 'email',
        suffixIcon: Icon(Icons.alternate_email),
        icon: Icon(Icons.email),
      ),
      onChanged: (valor) {
        _email = valor;
        setState(() {});
      },
    );
  }

  Widget _crearPassword() {
    return TextField(
      obscureText: true,
      keyboardType: TextInputType.emailAddress,
      decoration: InputDecoration(
        border: OutlineInputBorder(borderRadius: BorderRadius.circular(20.0)),
        hintText: 'Password',
        labelText: 'Password',
        suffixIcon: Icon(Icons.lock_open),
        icon: Icon(Icons.lock),
      ),
    );
  }

  Widget _crearFecha(BuildContext context) {
    return TextField(
      enableInteractiveSelection: false,
      controller: _inputfieldDateControler,
      keyboardType: TextInputType.emailAddress,
      decoration: InputDecoration(
        border: OutlineInputBorder(
          borderRadius: BorderRadius.circular(20.0),
        ),
        hintText: 'fecha de nacimiento',
        labelText: 'fecha',
        suffixIcon: Icon(Icons.calendar_today),
        icon: Icon(Icons.perm_contact_calendar),
      ),
      onTap: () {
        FocusScope.of(context).requestFocus(new FocusNode());
        _selectDate(context);
      },
    );
  }

  _selectDate(BuildContext context) async {
    DateTime picked = await showDatePicker(
        context: context,
        initialDate: new DateTime.now(),
        firstDate: new DateTime(2018),
        lastDate: new DateTime(2025),
        locale: Locale('es', 'ES'));

    if (picked != null) {
      setState(() {
        _fecha = picked.toString();
        _inputfieldDateControler.text = _fecha;
      });
    }
  }

  List<DropdownMenuItem<String>> getOPcionesDropdown() {
    List<DropdownMenuItem<String>> lista = new List();

    _poderes.forEach((poder) {
      lista.add(DropdownMenuItem(
        child: Text(poder),
        value: poder,
      ));
    });

    return lista;
  }

  Widget _crearDropdown() {
    return Row(
      children: [
        Icon(Icons.select_all),
        SizedBox(width: 30.0),
        DropdownButton(
          value: _opcionSelecionada,
          items: getOPcionesDropdown(),
          onChanged: (opt) {
            setState(() {
              _opcionSelecionada = opt;
            });
          },
        )
      ],
    );
  }

  Widget _crearpersona() {
    return ListTile(
      title: Text('nombre es : $_nombre'),
      subtitle: Text('email es : $_email '),
      trailing: Text(_opcionSelecionada),
    );
  }
}
