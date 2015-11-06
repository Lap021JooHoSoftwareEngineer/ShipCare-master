angular.module("SHIPCARE_PRO")
    .constant("dataUrl", "http://localhost:50107/api/lab021/1")
    .controller("SHIPCARE_PRO_Ctrl", function ($scope, $http, dataUrl) {
        $scope.data = {};

        $http.get(dataUrl)
            .success(function (data) {
                $scope.data.list = data;
            })
            .error(function (error) {
                $scope.data.error = error;
            });
    });