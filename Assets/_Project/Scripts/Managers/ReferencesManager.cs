﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjetoGatoPreto
{
    public class ReferencesManager : MonoBehaviour
    {
        private static ReferencesManager _instance;
        public static ReferencesManager instance
        {
            get
            {
                return _instance;
            }
        }

        public GameObject leftDropZone;
        public GameObject leftDecisionText;
        public GameObject rightDropZone;
        public GameObject rightDecisionText;
        public GameObject cardHolder;
        public GameObject dummyCard;
        public GameObject dummyCardFront;
        public GameObject card;
        public GameObject cardFront;
        public GameObject cardBack;
        public GameObject helpText;
        public GameObject cardDescription;
        public GameObject cardDescriptionText;
        public Deck deck;

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _instance = this;
            }
        }
    }
}