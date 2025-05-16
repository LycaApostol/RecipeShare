// Add your JavaScript functionality here

// Show loading spinner when submitting forms
$(document).ready(function () {
    $('form').on('submit', function () {
        if ($(this).valid()) {
            // Add loading state to buttons
            $(this).find('button[type="submit"]').prop('disabled', true);
            $(this).find('button[type="submit"]').html('<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span> Processing...');
        }
    });

    // Initialize tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    // Format ingredients and instructions on input
    $('#Ingredients').on('blur', function () {
        let ingredients = $(this).val();
        if (ingredients) {
            // Format ingredients as a comma-separated list if not already formatted
            if (!ingredients.includes('\n') && !ingredients.includes(',')) {
                let items = ingredients.trim().split(/\s{2,}/);
                $(this).val(items.join(', '));
            }
        }
    });

    $('#Instructions').on('blur', function () {
        let instructions = $(this).val();
        if (instructions) {
            // If instructions aren't already numbered, number them
            if (!instructions.match(/^\d+\.\s/m)) {
                let steps = instructions.split(/\n+/).filter(s => s.trim().length > 0);
                let numberedSteps = steps.map((step, index) => `${index + 1}. ${step.trim()}`);
                $(this).val(numberedSteps.join('\n'));
            }
        }
    });

    // Preview image when URL is entered
    $('#ImageUrl').on('blur', function () {
        let imageUrl = $(this).val();
        if (imageUrl && imageUrl.trim().length > 0) {
            // Simple validation for URL format
            if (imageUrl.match(/^https?:\/\/.+\..+/)) {
                // Show preview
                if (!$('#imagePreview').length) {
                    $(this).after('<div class="mt-2"><img id="imagePreview" class="img-thumbnail" style="max-height: 150px;" /></div>');
                }
                $('#imagePreview').attr('src', imageUrl);
            }
        } else {
            $('#imagePreview').remove();
        }
    });

    // Make cards of equal height
    function equalizeCardHeights() {
        $('.card-title').css('height', 'auto');

        let maxHeight = 0;
        $('.card-title').each(function () {
            if ($(this).height() > maxHeight) {
                maxHeight = $(this).height();
            }
        });

        $('.card-title').height(maxHeight);
    }

    // Call on page load and resize
    equalizeCardHeights();
    $(window).resize(equalizeCardHeights);
});