class Types {
  String first;
  String second;
  int length;

  Types({this.first, this.second, this.length});

  Types.fromJson(List<dynamic> json) {
    length = json.length;
    first = json[0]["type"]["name"];
    second = json.length == 2 ? json[1]["type"]["name"] : "N/A";
  }
}