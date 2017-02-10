function sucessMessage(success) {

            Messenger.options = {
                extraClasses: 'messenger-fixed messenger-on-bottom messenger-on-right',
                theme: 'flat'
            }

            Messenger().post({
                message: success,
                type: 'success',
                showCloseButton: true
            });
        }

        function errorMessage(errorMessage) {
            Messenger.options = {
                extraClasses: 'messenger-fixed messenger-on-bottom messenger-on-right',
                theme: 'flat'
            }

            Messenger().post({
                message: errorMessage,
                type: 'error',
                showCloseButton: true
            });
        }