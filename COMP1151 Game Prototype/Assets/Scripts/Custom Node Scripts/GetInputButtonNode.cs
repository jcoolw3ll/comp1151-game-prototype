using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

/// GetInputButtonNode - Custom Visual Scritping Node
/// by Malcolm Ryan
///
/// This node detects whether a button action input has been pressed, held or released.
/// 
/// Licensed under Creative Commons License CC0 Universal
/// https://creativecommons.org/publicdomain/zero/1.0/

namespace WordsOnPlay.Nodes {

public class GetInputButtonNode : Unit
{
    public enum ButtonResponse {
        WasPressedThisFrame,
        WasReleasedThisFrame,
        IsPressed
    }

    [DoNotSerialize]
    public ControlInput inputTrigger;

    [DoNotSerialize]
    public ControlOutput outputTrigger;

    [DoNotSerialize]
    public ValueInput buttonResponseValue;

    [DoNotSerialize]
    public ValueInput inputValue;

    [DoNotSerialize]
    public ValueInput mappingValue;

    [DoNotSerialize]
    public ValueInput actionValue;

    [DoNotSerialize]
    public ValueOutput resultValue;

    private bool output;

    protected override void Definition()
    {
        //The lambda to execute our node action when the inputTrigger port is triggered.
        inputTrigger = ControlInput("inputTrigger", (flow) =>
        {
            //Making the resultValue equal to the input value from myValueA concatenating it with myValueB.
            InputActionAsset input = flow.GetValue<InputActionAsset>(inputValue);
            InputActionMap mapping = input.FindActionMap(flow.GetValue<string>(mappingValue));
            if (mapping == null) 
            {
                throw new ArgumentException($"{input.name} does not include the mapping '{flow.GetValue<string>(mappingValue)}'");
            }

            InputAction action = mapping.FindAction(flow.GetValue<string>(actionValue));
            if (action == null) 
            {
                throw new ArgumentException($"{input.name}.{mapping.name} does not include the action '{flow.GetValue<string>(actionValue)}'");
            }

            switch (flow.GetValue<ButtonResponse>(buttonResponseValue)) {

                case ButtonResponse.WasPressedThisFrame:
                    output = action.WasPressedThisFrame();
                    break;

                case ButtonResponse.WasReleasedThisFrame:
                    output = action.WasReleasedThisFrame();
                    break;

                case ButtonResponse.IsPressed:
                    output = action.IsPressed();
                    break;
            }

            return outputTrigger;
        });
        outputTrigger = ControlOutput("outputTrigger");

        buttonResponseValue = ValueInput<ButtonResponse>("button response", ButtonResponse.IsPressed);
        inputValue = ValueInput<InputActionAsset>("input asset", null);
        mappingValue = ValueInput<string>("mapping", String.Empty);
        actionValue = ValueInput<string>("action", String.Empty);
        resultValue = ValueOutput<bool>("result", (flow) => output);

        Requirement(inputValue, inputTrigger);
        Requirement(mappingValue, inputTrigger);
        Requirement(actionValue, inputTrigger);
        Succession(inputTrigger, outputTrigger);

        Assignment(inputTrigger,resultValue);
    }
}

}