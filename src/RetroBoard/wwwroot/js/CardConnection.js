

// SignalR's hub object.
var cardHub = $.connection.cardMessageHub;

$(function () {
    $.connection.hub.logging = true;
    $.connection.hub.start();
});


cardHub.client.handleCardMessage = function (message) {
    $scope.receivedMessageHandler(message);
};
