var app = angular.module('IssuesModule', []);

app.controller('IssuesController', function ($scope, $http) {
    $scope.test = "Hello World";
    $scope.issues = {};

    $scope.getIssues = function () {
        $http({
            url: "/api/Issue",
            method: "GET",
        }).then(function (response) {
            $scope.issues = response.data;
            console.log($scope.issues);
        });
    };
    $scope.getIssues();

});
