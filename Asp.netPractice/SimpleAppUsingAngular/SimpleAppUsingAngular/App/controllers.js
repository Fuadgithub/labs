(function () {
    angular
        .module('MovieApp')
        .controller('PetListController', function () {
            this.category = [
                { animal: 'Bunnies', name: ['Chuchu', 'Lilu'] } ,
                { animal: 'Dogs', name: [ 'Jacky','Ricki'] }
             ];              
        })
})();