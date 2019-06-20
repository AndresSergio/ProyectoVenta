using MiChofer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiChofer.Services
{
    class Session
    {

        //Singleton
        private static Session m_instance;

        public static Session Instance
        {
            get {
                if (m_instance == null)
                    m_instance = new Session();

                return m_instance;
            }
            set { m_instance = value; }
        }


        //Propiedades de la sesion.
        public enum UserType
        { Company, Driver }


        private static UserType m_userType;

        public static UserType Type
        {
            get { return m_userType; }
            set { m_userType = value; }
        }

        private static User m_user;

        public static User User
        {
            get { return m_user; }
            set { m_user = value; }
        }

        //Funciones publicas
        public bool LoginDriverFacebook(FacebookProfile _fb)
        {
            if(m_user != null)
                return false;

            m_user = new Driver(_fb);
            App.masterVm.SetUserData(m_user);
            return true;
        }

        //Accesores
        public static int GetId() { return m_user.Id; }
        public static string GetName() { return m_user.Name; }
        public static string GetPhone() { return m_user.Phone; }       
        public static string GetEmail() { return m_user.Email; }
        public static string GetPassword() { return m_user.Password; }
        public static string GetImage() { return m_user.Image; }
        //.. TODO: Rellenar mas datos

    }
}
