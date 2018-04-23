# How to use a ComboBoxEdit whose choices are different for each cell in the grid


<p>There are two ways to accomplish this task: via filter criteria and by using a multibinding approach. Let me explain theses approaches in detail.</p>
<br />
<p>1) Filter criteria</p>
<p>The main idea is to dynamically construct a filter by using the selected value of the first column in the grid. So, items in the ComboBox editor will be filtered automatically according to the filter's value. In this case, it is necessary to create a converter (which implements the IValueConverter interface) in the code-behind file.</p>
<p><br /> 2) Multibinding approach.<br /> You can also resolve this problem by using the multibinding approach. Specify multiple bindings in a MultiBinding object and create a converter (which implements the IMultiValueConverter interface) to produce a final value for the binding target property based on values of those bindings.</p>

<br/>


