window.frequencyDialogs = {
    open(dialog) {
        if (dialog && !dialog.open) dialog.showModal();
    },
    close(dialog) {
        if (dialog && dialog.open) dialog.close();
    }
};
