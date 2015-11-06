var SHIP_PF_KPI = angular.module("SHIP_PF_KPI", []);

SHIP_PF_KPI.controller("SHIP_PF_KPI_Ctrl", function ($scope, $http) {
    $http.get("../Views/Script/Json/ShipPerformanceKPI.json").success(function (data) {
        var jsonString = angular.toJson(data);
        console.log(jsonString);
        $scope.KPI_Mock = angular.fromJson(jsonString);
    });
});