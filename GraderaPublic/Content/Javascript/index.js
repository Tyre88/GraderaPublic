(function (angular) {
    angular.module('gradera', ["ng", "ngMaterial"]);

    angular.module('gradera').controller('index', indexController);

    angular.module('gradera').directive('lazyLoad', lazyLoadDirective);

    indexController.$inject = ["$mdDialog"];

    function indexController($mdDialog) {
        var vm = this;
        vm.HasShownDonate = sessionStorage.getItem("donate");
        vm.ShowCounter = sessionStorage.getItem("donateCounter");

        if (!vm.ShowCounter) {
            vm.ShowCounter = 1;
        }
        else {
            ~~vm.ShowCounter++;

            if (~~vm.ShowCounter > 5) {
                vm.ShowCounter = 1;
            }
        }

        sessionStorage.setItem('donateCounter', vm.ShowCounter);

        if (!vm.HasShownDonate || (vm.ShowCounter && ~~vm.ShowCounter == 1)) {
            //$mdDialog.show({
            //    controller: donateController,
            //    controllerAs: "vm",
            //    templateUrl: "donate.html"
            //});
        }

        donateController.$inject = ["$mdDialog"];

        function donateController($mdDialog) {
            var vm = this;

            vm.Ok = Ok;

            function Ok() {
                sessionStorage.setItem("donate", true);
                $mdDialog.hide();
            }
        }
    }

    function lazyLoadDirective() {
        return {
            restrict: 'A',
            link: function (scope, element, attrs) {
                const observer = new IntersectionObserver(loadImg);
                const img = angular.element(element)[0];
                observer.observe(img);

                function loadImg(changes) {
                    changes.forEach(change => {
                        if (change.intersectionRatio > 0) {
                            change.target.src = attrs.lazyLoad;
                        }
                    });
                }

            }
        };
    }
    
    angular.bootstrap(document, ["gradera"]);
}(window.angular));