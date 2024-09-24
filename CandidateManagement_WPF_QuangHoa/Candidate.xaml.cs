using Candidate_BusinessObjects;
using Candidate_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CandidateManagement_WPF_QuangHoa
{
    /// <summary>
    /// Interaction logic for Candidate.xaml
    /// </summary>
    public partial class Candidate : Window
    {
        private CandidateProfileService candidateService;
        private IJobPostingService jobPostingService;

        public Candidate()
        {
            InitializeComponent();
            candidateService = new CandidateProfileService();
            jobPostingService = new JobPostingService();
        }

        
      

        private void btnJobPosting_Click(object sender, RoutedEventArgs e)
        {
            JobPostingWindow jobPostingWindow = new JobPostingWindow();
            jobPostingWindow.Show();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidateProfile= new CandidateProfile();
            candidateProfile.CandidateId = txt_CandidateId.Text;
            candidateProfile.Fullname = txt_FullName.Text;
            candidateProfile.Birthday = DateTime.Parse(date_birthday.Text);
            candidateProfile.ProfileUrl = txt_ProfileUrl.Text;
            //candidateProfile.Posting = jobPostingService.getJobPostingById(cbb_JobPosting.SelectedValue.ToString());
            candidateProfile.PostingId = cbb_JobPosting.SelectedValue.ToString();
            candidateProfile.ProfileShortDescription = txt_Description.Text;
            if (candidateService.AddCandidateProfile(candidateProfile))
            {
                MessageBox.Show("Add Success");
                loadDataInit();
            }
            else
            {
                MessageBox.Show("Please contact Mr.Hòa");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txt_CandidateId.Text.Length > 0 && candidateService.RemoveCandidateProfile(txt_CandidateId.Text))
            {
                string name = txt_FullName.Text;
                MessageBox.Show($"Delete {name} successfull");
                loadDataInit();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(txt_CandidateId.Text.Length > 0 && candidateService.UpdateCandidateProfile(txt_CandidateId.Text))
            {
                MessageBox.Show("Update successfull");
                loadDataInit();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadDataInit();

        }

        private void loadDataInit()
        {
            this.dtg_candidateProfile.ItemsSource = candidateService.GetCandidateProfilesList();
            this.cbb_JobPosting.ItemsSource = jobPostingService.getJobPostingsList();
            this.cbb_JobPosting.DisplayMemberPath = "JobPostingTitle";
            this.cbb_JobPosting.SelectedValuePath = "PostingId";

            txt_CandidateId.Text = "";
            txt_FullName.Text = "";
            date_birthday.Text = "";
            txt_ProfileUrl.Text = "";
            cbb_JobPosting.SelectedValue = "";
            txt_Description.Text = "";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_FullName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_BirthDay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_ProfileUrl_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_JobPostingId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_Description_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbb_JobPosting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dtg_candidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator
                                                    .ContainerFromIndex(dataGrid.SelectedIndex);
            if(row != null)
            {

            
            DataGridCell column = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)column.Content).Text;
            CandidateProfile candidateProfile = candidateService.GetCandidateProfileById(id);
            if (candidateProfile != null)
            {
                txt_CandidateId.Text = candidateProfile.CandidateId;
                txt_FullName.Text = candidateProfile.Fullname;
                date_birthday.Text = candidateProfile.Birthday.ToString();
                txt_ProfileUrl.Text = candidateProfile.ProfileUrl;
                cbb_JobPosting.SelectedValue = candidateProfile.PostingId;
                txt_Description.Text = candidateProfile.ProfileShortDescription;
            }
            }
            
        }
    }
}
