# Write Control Prompt

## Description

The Write Control API is a powerful tool that allows you to control the output of the AIWriteAssist API. 
This API is designed to give you more control over the output of the AIWriteAssist API by allowing you to 
specify the tone, style, and content of the generated text. This API is especially useful for generating text 
that is consistent with your brand voice, or for generating text that is more likely to achieve a specific goal.

## Prompt Development

1. **Does not work**
```
I want to create a compound custom control for writing texts. 
It should consist of a ToolStrip (top-docked) and a RichTextBox (filled-docked). 
The most important properties for controlling the RichTextBox should be marshalled up and down,
which are all those properties which are specific to RichTextBox to attribute the content.
```
2. **Does not work**
Add: 
```
Make sure, you take ALL RichTextBox specific properties for that into account and do not leave anything out.
```

3. **Let's make it work**
* Open the Co-Pilot Chat window
* Enter: Please list all the RichTextBox specific properties. List them just by their names, comma separated.
* Copy the list of the properties.
* Let's add to the original prompt:
```
I want to create a compound custom control for writing texts. 
It should consist of a ToolStrip (top-docked) and a RichTextBox (filled-docked). 
The most important properties for controlling the RichTextBox should be marshalled up and down,
so please make sure you take ALL the following properties into account: {properties list}
```

4. **Let's do that for all the events:**
* Change to the Copilot Chat window
* Enter: Please list all the RichTextBox specific events. List them just by their names, comma separated.
* In the Code Copilot prompt, add:
```
The most important events for controlling the RichTextBox should be marshalled up and down,
so please make sure you take ALL the following events into account: {events list}
Please use expression bodies both for setter and getter where possible.
```

5. **Let's clean up the class a bit:**
```
Can you create a new code file with a partial class named "WriteControl_Properties" 
and move all the properties in there?
```

But now, the properties are double defined. And also, the original class is not partial. So:

```
Can you make this class partial, and delete all properties?
```
