//import 'package:flutter/rendering.dart';
import 'package:sql_mock_entrega/pages/Sqlite/page/providers/db_provider.dart';
import 'package:sql_mock_entrega/pages/Sqlite/page/models/employee_model.dart';
import 'package:dio/dio.dart';

class EmployeeApiProvider {
  Future<List<Employee>> getAllEmployees() async {
    Response response;

    var url = "http://demo9145205.mockable.io/fluttertest";
    response = await Dio().get(url);
    print(response);
    return (response.data as List).map(
      (employee) {
        print('Inserting $employee');
        DBProvider.db.createEmployee(Employee.fromJson(employee));
      },
    ).toList();
  }
}
