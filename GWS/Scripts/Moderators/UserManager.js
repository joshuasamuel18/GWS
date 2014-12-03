var UserManagerApp = angular.module("UserManagerApp", []);

function UserManagerCtrl($scope) {



    $scope.Register = function ()
    {
        if(!$scope.RegisterForm.$valid)
        {
            alert("not valid");
//            toastr.warning('Validation failed : Plese enter valid values in the highlighted mandatory fields.', 'User Registration');
            //$('input.ng-invalid').effect("pulsate", { times: 3 }, 2000);          
            return;
        }
        else {
  //          toastr.clear();
    //        toastr.info('Registering User...', 'Save');
        }

    }
}