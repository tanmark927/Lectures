using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Cecs475.Scheduling.RegistrationApp
{
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
            ViewModel.ApiUrl = "http://localhost:51735/";
		}

		public RegistrationViewModel ViewModel => FindResource("ViewModel") as RegistrationViewModel;

		private void mValidateBtn_Click(object sender, RoutedEventArgs e) {
			var client = new RestClient(ViewModel.ApiUrl);
			var request = new RestRequest("api/students/{name}", Method.GET);
			request.AddUrlSegment("name", ViewModel.FullName);

			var response = client.Execute(request);
			if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
				MessageBox.Show("Student not found");
			else
				MessageBox.Show("Success!");
		}

		private void mRegisterBtn_Click(object sender, RoutedEventArgs e) {
			string[] courseSplit = mCourseText.SelectedItem.ToString().Split('-');
			int sectionNum = Convert.ToInt32(courseSplit[1]);
			string[] nameSplit = courseSplit[0].Split(' ');

			var client = new RestClient(ViewModel.ApiUrl);
			var request = new RestRequest("api/students/{name}", Method.GET);
			request.AddUrlSegment("name", ViewModel.FullName);
			var response = client.Execute(request);
			if (response.StatusCode == System.Net.HttpStatusCode.NotFound) {
				MessageBox.Show("Student not found");
			}
			else {
				request = new RestRequest("api/register", Method.POST);

				JObject obj = JObject.Parse(response.Content);
				request.AddJsonBody(new {
					StudentId = (int)obj["Id"],
					CourseSection = new {
						SemesterTermId = ((SemesterTermDto)mSemesterText.SelectedItem).Id,
						CatalogCourse = new {
							DepartmentName = nameSplit[0],
							CourseNumber = nameSplit[1]
						},
						SectionNumber = sectionNum,
					}
				});

				response = client.Execute(request);
				if (response.StatusCode == System.Net.HttpStatusCode.NotFound) {
					MessageBox.Show("Course not found");
				}
				else {
					int result = Convert.ToInt32(response.Content);
					MessageBox.Show(result.ToString());
				}
			}
		}

		private async void mAsyncBtn_Click(object sender, RoutedEventArgs e) {
            string[] courseSplit = mCourseText.SelectedItem.ToString().Split('-');
            int sectionNum = Convert.ToInt32(courseSplit[1]);
			string[] nameSplit = courseSplit[0].Split(' ');

			var client = new RestClient(ViewModel.ApiUrl);
			var request = new RestRequest("api/students/{name}", Method.GET);
			request.AddUrlSegment("name", ViewModel.FullName);

			var task = client.ExecuteTaskAsync(request);
			var response = await task;

			if (response.StatusCode == System.Net.HttpStatusCode.NotFound) {
				MessageBox.Show("Student not found");
			}
			else {
				request = new RestRequest("api/register", Method.POST);
				JObject obj = JObject.Parse(response.Content);
				request.AddJsonBody(new {
					StudentId = (int)obj["Id"],
					CourseSection = new {
						SemesterTermId = ((SemesterTermDto)mSemesterText.SelectedItem).Id,
						CatalogCourse = new {
							DepartmentName = nameSplit[0],
							CourseNumber = nameSplit[1]
						},
						SectionNumber = sectionNum,
					}
				});

				response = await client.ExecuteTaskAsync(request);
				if (response.StatusCode == System.Net.HttpStatusCode.NotFound) {
					MessageBox.Show("Course not found");
				}
				else {
					int result = Convert.ToInt32(response.Content);
					MessageBox.Show(result.ToString());
				}
			}
		}

        private async void mAsyncLoaded(object sender, RoutedEventArgs e) {
            var client = new RestClient(ViewModel.ApiUrl);
            var request = new RestRequest("api/schedule/terms", Method.GET);
            var response = await client.ExecuteTaskAsync<List<SemesterTermDto>>(request);

            ViewModel.StdList = response.Data;
        }

        private async void mAsyncSelectionChanged(object sender, SelectionChangedEventArgs e) {
            var obj = (SemesterTermDto)(sender as ComboBox).SelectedItem;
            var client = new RestClient(ViewModel.ApiUrl);
            var request = new RestRequest("api/schedule/{id}", Method.GET);
            request.AddUrlSegment("id", obj.Id.ToString());

            var response = await client.ExecuteTaskAsync(request);
            ViewModel.CsdList = JsonConvert.DeserializeObject<List<CourseSectionDto>>(response.Content);
        }
    }
}
