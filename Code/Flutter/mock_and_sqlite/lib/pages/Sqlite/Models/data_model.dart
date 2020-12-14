import 'dart:convert';

List<Data> employeeFromJson(String str) =>
    List<Data>.from(json.decode(str).map((x) => Data.fromJson(x)));

String employeeToJson(List<Data> data) =>
    json.encode(List<dynamic>.from(data.map((x) => x.toJson())));

class Data {
  int id;
  String email;
  String firstName;
  String lastName;
  String avatar;

  Data({
    this.id,
    this.email,
    this.firstName,
    this.lastName,
    this.avatar,
  });

  factory Data.fromJson(Map<String, dynamic> json) => Data(
        id: json["id"],
        email: json["email"],
        firstName: json["firstName"],
        lastName: json["lastName"],
        avatar: json["avatar"],
      );

  Map<String, dynamic> toJson() => {
        "id": id,
        "email": email,
        "firstName": firstName,
        "lastName": lastName,
        "avatar": avatar,
      };
}
