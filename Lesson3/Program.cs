class Program
{
    static void Main(string[] args)
    {

        var therapist1 = new Therapist
        {
            Name = "Иван Иванов",
            Age = 40,
            Specialization = "Терапевт, пульманолог",
            Experience = "2 года ординатуры и 13 лет работы в поликлинике",
            DoctorsDistrict = 1
        };

        var therapist2 = new Ophthalmologist
        {
            Name = "Мария Мариева",
            Age = 55,
            Specialization = "Терапевт, гастроэнтеролог",
            Experience = "2 года ординатуры и 25 лет работы в поликлинике"
        };

        var neurolog1 = new Neurolog
        {
            Name = "Александр Александров",
            Age = 45,
            Specialization = "Невролог",
            Experience = "2 года ординатуры, 18 лет работы в поликлинике"
        };

        var patient1 = new TherapyPatient
        {
            Name = "Ольга Ольгова",
            Age = 20,
            Disease = "ОРЗ",
            Insurance = "ОМС",
            Sickness = true,
            District = 1
        };

        var patient2 = new TherapyPatient
        {
            Name = "Максим Максимов",
            Age = 40,
            Insurance = "ОМС",
            Sickness = true,
            Disease = "Язвенная болезнь желудка",
            District = 1
        };

        var patient3 = new NeurologicalPatient
        {
            Name = "Татьяна Татьянова",
            Age = 30,
            Disease = "Эпилепсия",
            Insurance = "ОМС",
            Sickness = true,
            EpilepticStatus = true
        };
        patient3.Information();
        patient3.DoctorsAppointment(neurolog1);
        neurolog1.Information();
        neurolog1.Treatment(patient3);

        patient2.Information();
        patient2.DoctorsAppointment(therapist2);
        therapist2.Information();
        therapist2.Treatment(patient2);

        patient1.Information();
        patient1.DoctorsAppointment(therapist1);
        therapist1.Information();
        therapist1.Treatment(patient1);
    }
}