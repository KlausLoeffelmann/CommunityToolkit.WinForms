# Write Control Prompt

## Description

The Write Control API is a powerful tool that allows you to control the output of the AIWriteAssist API. 
This API is designed to give you more control over the output of the AIWriteAssist API by allowing you to 
specify the tone, style, and content of the generated text. This API is especially useful for generating text 
that is consistent with your brand voice, or for generating text that is more likely to achieve a specific goal.

## Prompt Development - basic Setup

1. Derive the RTF Control into the PromptControl
2. Explain the planned VisualStyles and what it means for TextBoxBase
3. With this knowledge, suggest to set the Padding to 5, 20, 5, 5
4. Run the Program to demo the Padding
5. Note, that the Padding is not applied - ask the audience if someone has an idea!
6. Show InitializeComponent, and say that the Padding serialized by the designer. And that there are countless
   circumstances where the designer could serialize a property without the developer noticing it. Delete the 
   serialization code line.
7. So, lets quickly fix this: Shadow the Padding property:

```
    public new Padding Padding { get; set; } = new(10, 5, 30, 5);
```

8. Point out the new Analyzer and the options.
    a) Default Value (`[DefaultValue(typeof(Padding), "10, 5, 30, 5")]`)
    b) `private bool ShouldSerializePadding() => false;`
    c) The Analyzer CodeFix.

We settle for the Analyzer CodeFix.

## Implementing custom Adorner Painting

We want to implement a typical Prompt-Send-Button, but that button should rather be
part of the control rather than a separate control. So, we want to add something like
a custom adorner painting to the control, where that part of the adorner practically
is the button. So, the question is, how would we implement it?

And now, here is the general thing with prompting:

Attempt 01:
```
01 Can you add the code which adds a custom drawn typical 
"prompt instruction send" button to the control?
```

OK, that's obviously not gonne work. For once, we cannot add a button to the control, because
there is no way that the underlaying win32 edit control could be made to show a button this way.
This is simply not a container control. And secondly, we do not want to add a button to the control,
because then we would create a composite control, which means that at least two or more constituent
controls would make up the new one, which in turn means that the new control would not only cost way
more resources, but also would be way more complex to handle: For example, we would need to marshal
all the properties we need of the constituent controls to the new control, and we would need to
implement all the events of the constituent controls in the new control, and we would need to
handle the focus of the constituent controls in the new control, and so on.

So, prompts as unspecific as the one above are not helpful.
Let's make a more concrete suggestion:

Attempt 01:
```
02 Can you add the code which adds a custom drawn typical "prompt send" button-like
area to the control by painting it?
```

Attempt 02:
```
03 I want to add the render-logic for a clickable "prompt-send" symbol into this PromptControl. 
I do not want to render it inside of OnPaint as part of the client-content rendering, 
but rather implement something to render in the context of system elements 
more safely. Can you amend the non-client paint logic for that and include the rendering 
of the symbol?
```

Attempt 03:
```
04 I want to add the render-logic for a clickable "prompt-send" symbol into this PromptControl. 
I do not want to render it inside of OnPaint as part of the client-content rendering, but rather 
implement something to render in the context of system elements more safely. Can you amend a non-client 
paint logic for that and include a method for the rendering of the symbol right-aligned in the control 
in the height of the cursor?
```

Refactoring 01 for Attempt 03:
```
05 Isn't there a Segeo-based Font with fluent-style icons we could use? If yes, can we find the symbol 
characters for Send and a filled Send, and use those for rendering? Can you refactor the code to render 
with those, and chose the right one when the Mouse hovers over it?
```
