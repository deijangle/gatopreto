﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjetoGatoPreto
{
    public class Player : MonoBehaviour
    {
        public static float maxAttributeValue = 100f;
        public static float minAttributeValue = 0f;
        public static float lowAttributePercentage = 0.1f;
        public static float highAttributePercentage = 0.8f;
        public float[] attributeValues = new float[Enum.GetValues(typeof(PlayerAttribute)).Length];

        public float this[PlayerAttribute i] {
            get { return attributeValues[(int) i]; }
            set { attributeValues[(int) i] = value; }
        }

        public void ApplyDecisionEffects(CardDecision decision)
        {
            foreach (CardEffect effect in decision.decisionEffects)
            {
                ApplyEffect(effect);
            }
        }

        public void ApplyEffect(CardEffect effect)
        {
            switch (effect.operation)
            {
                case EffectOperation.ADD:
                    attributeValues[(int) effect.attribute] += effect.value;
                    break;
                case EffectOperation.MULTIPLY:
                    attributeValues[(int) effect.attribute] *= effect.value;
                    break;
                case EffectOperation.SET:
                    attributeValues[(int) effect.attribute] = effect.value;
                    break;
            }
            if (effect.callEvent != null)
                effect.callEvent.Invoke();
        }
    }
}