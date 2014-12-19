/**
 * cordova FilePicker WP plugin
 */
 (function(cordova){
    var FilePickerWP = function() {

    };

    FilePickerWP.prototype.open = function(params, success, fail) {
        return cordova.exec(function(args) {
            success(args);
        }, function(args) {
            fail(args);
        }, 'FilePickerWP', 'open', [params||{}]);
    };

    window.filepickerWP = new FilePickerWP();
    
    window.plugins = window.plugins || {};
    window.plugins.filePickerWP = window.filePickerWP;
})(window.PhoneGap || window.Cordova || window.cordova);