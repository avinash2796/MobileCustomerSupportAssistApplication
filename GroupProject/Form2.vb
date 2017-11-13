Public Class Form2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Select Operator ")
        ComboBox1.Items.Add("Airtel")
        ComboBox1.Items.Add("Aircel")
        ComboBox1.Items.Add("BSNL")

        ComboBox1.Items.Add("Idea")
        ComboBox1.Items.Add("Vodafone")
        ComboBox1.SelectedIndex = 0
        ComboBox2.Items.Add("Select Task")
        ComboBox2.Items.Add("Introduction")
        ComboBox2.Items.Add("All Offers")
        ComboBox2.Items.Add("All Tarrif Plans")

        ComboBox2.Items.Add("Get a new Sim")
        ComboBox2.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.SelectedIndex
            Case 1

                Select Case ComboBox2.SelectedIndex
                    Case 1
                        MsgBox("Bharti Airtel is an Indian global telecommunications
services company based in New Delhi, India. It operates
in 19 countries across South Asia and Africa.
Airtel provides GSM, 3G and 4G LTE mobile services,
fixed line broadband and voice services depending
upon the country of operation. It is the largest mobile
network operator in India and the third largest in the
world with 325 million subscribers.")
                    Case 2
                        Form9.Show()
                    Case 3
                        Form10.Show()
                    Case 4
                        MessageBox.Show("You need -
Your self attested photograph 
Your photo proof of identity / signature
The proof of your address")
                End Select

            Case 2

                Select Case ComboBox2.SelectedIndex
                    Case 1
                        MsgBox("  Aircel is an Indian mobile network operator
headquartered in Gurgaon, which offers voice and 2G, 3G and 4G data services.
Maxis Communications holds a 74% stake and Sindya Securities and Investments
holds the remaining 26%.[4] Aircel was founded by C Sivasankaran and commenced
operations in Tamil Nadu in 1999. It is the sixth largest mobile service
provider in India with a subscriber base of 83.05 million 
subscribers as of June 2015.Aircel is a market leader in Tamil Nadu and
has considerable presence in Odisha, Assam and North-East telecom circles.")
                    Case 2
                        Form12.Show()
                    Case 3
                        Form13.Show()
                    Case 4
                        MessageBox.Show("Visit At Aircel Online Store .
Fill The Form .
Enter Your Name, Location. Contact Number. State Etc.
Enter A Phone Number To Receive An OTP From Aircel .
Enter OTP In Required Place.
Click On Submit Button.")
                End Select
            Case 3

                Select Case ComboBox2.SelectedIndex
                    Case 1
                        MsgBox("Bharat Sanchar Nigam Limited (abbreviated BSNL) is an Indian 
state-owned telecommunications company headquartered in New Delhi. It was incorporated 
on 15 September 2000 and took over the business of providing of telecom services and 
network management from the erstwhile Central Government Departments of Telecom Services (DTS) 
and Telecom Operations (DTO), with effect from 1 October 2000 on a going concern basis. It is 
the largest provider of fixed telephony and broadband services with more than 60% market share 
and Fifth largest mobile telephony provider in India.")
                    Case 2
                        Form14.Show()
                    Case 3
                        Form15.Show()
                    Case 4
                        MessageBox.Show("You need -
Your self attested photograph
Your photo proof of identity / signature
The proof of your address")
                End Select
            Case 4

                Select Case ComboBox2.SelectedIndex
                    Case 1
                        MsgBox("Idea Cellular (commonly referred to as simply Idea, and stylised 
as !dea) is an Indian mobile network operator based in Mumbai, Maharashtra. Idea is a pan-India 
integrated GSM operator offering 2G,3G and 4G mobile services. Idea is India’s third largest mobile 
operator by subscriber base, After Vodafone India. Idea has 182 million subscribers as 
of 31 December 2015.")
                    Case 2
                        Form16.Show()
                    Case 3
                        Form17.Show()
                    Case 4
                        MessageBox.Show("You need -
Your self attested photograph
Your photo proof of identity / signature
The proof of your address")
                End Select
            Case 5

                Select Case ComboBox2.SelectedIndex
                    Case 1
                        MsgBox("Vodafone Group plc /ˈvoʊdəfoʊn/ is a British multinational telecommunications company, 
with headquarters in London.Among mobile operator groups globally, Vodafone ranked fifth by revenue and 
second (behind China Mobile) in the number of connections (435.9 million) as of 2014.Vodafone owns and operates networks 
in 26 countries and has partner networks in over 50 additional countries.Its Vodafone Global Enterprise division provides 
telecommunications and IT services to corporate clients in 150 countries.")
                    Case 2
                        Form18.Show()
                    Case 3
                        Form19.Show()
                    Case 4
                        MessageBox.Show("You need -
Your self attested photograph
Your photo proof of identity / signature
The proof of your address")
                End Select

        End Select

    End Sub
End Class