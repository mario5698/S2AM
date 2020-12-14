import 'package:dio/dio.dart';
import 'package:mock_and_sqlite/pages/Sqlite/Provider/db_provider.dart';
import 'package:mock_and_sqlite/pages/Sqlite/Models/data_model.dart';

class DataApiProvider {
  Future<List<Data>> getAllEmployees() async {
    var url =
        "https://raw.githubusercontent.com/mario5698/S2AM/master/json%20bakcup/ICB0-M08U01IA05/data.json";
    Response response = await Dio().get(url);

    return (response.data as List).map((data) {
      print('Inserting $data');
      DBProvider.db.createEmployee(Data.fromJson(data));
    }).toList();
  }
}
