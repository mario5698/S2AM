import 'package:mock_and_sqlite/pages/Sqlite/page/providers/db_provider.dart';
import 'package:mock_and_sqlite/pages/Sqlite/page/models/employee_model.dart';
import 'package:dio/dio.dart';

class EmployeeApiProvider {
  Future<List<Employee>> getAllEmployees() async {
    var url =
        "https://raw.githubusercontent.com/mario5698/S2AM/master/json%20bakcup/ICB0-M08U01IA05/data.json";
    Response response = await Dio().get(url);

    return (response.data as List).map((employee) {
      print('Inserting $employee');
      DBProvider.db.createEmployee(Employee.fromJson(employee));
    }).toList();
  }
}
