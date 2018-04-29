﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Alberto Rodríguez Orozco & LiveCharts contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
// of the Software, and to permit persons to whom the Software is furnished to 
// do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
// OTHER DEALINGS IN THE SOFTWARE.
#endregion
#region

using LiveCharts.Core.Charts;
using LiveCharts.Core.Coordinates;
using LiveCharts.Core.DataSeries;
using LiveCharts.Core.Interaction.ChartAreas;

#endregion

namespace LiveCharts.Core.Interaction.Points
{
    /// <summary>
    /// A boxed copy of the <see cref="Point{TModel,TCoordinate,TViewModel, TSeries}"/> class.
    /// </summary>
    public class PackedPoint
    {
        private readonly object _packingSource;

        internal PackedPoint(object packingSource)
        {
            _packingSource = packingSource;
        }

        /// <summary>
        /// Gets the key of the point, a key is used internally as a unique identifier in 
        /// in a <see cref="Series"/> 
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public int Key { get; internal set; }

        /// <summary>
        /// Gets the instance represented by this point.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public object Model { get; internal set; }

        /// <summary>
        /// Gets the view model,the model to drawn in the user interface.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public object ViewModel { get; internal set; }

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        public object View { get; internal set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        /// <value>
        /// The point.
        /// </value>
        public ICoordinate Coordinate { get; set; }

        /// <summary>
        /// Gets or sets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public InteractionArea InteractionArea { get; set; }

        /// <summary>
        /// Gets the series that owns the point.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        public ISeries Series { get; internal set; }

        /// <summary>
        /// Gets the chart that owns the point.
        /// </summary>
        /// <value>
        /// The chart.
        /// </value>
        public ChartModel Chart { get; internal set; }

        /// <summary>
        /// Gets the tooltip text.
        /// </summary>
        /// <value>
        /// The tooltip text.
        /// </value>
        public string TooltipText => Series.GetTooltipLabel(Coordinate);

        /// <summary>
        /// Gets the data label string.
        /// </summary>
        /// <value>
        /// The data label string.
        /// </value>
        public string DataLabelString => Series.GetDataLabel(Coordinate);

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj, _packingSource);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return _packingSource.GetHashCode();
        }
    }

    /// <summary>
    /// A boxed copy of the <see cref="Point{TModel,TCoordinate,TViewModel, TSeries}"/> class.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <typeparam name="TCoordinate">The type of the coordinate.</typeparam>
    public class PackedPoint<TModel, TCoordinate>
        where TCoordinate : ICoordinate
    {
        private readonly object _packingSource;

        internal PackedPoint(object packingSource)
        {
            _packingSource = packingSource;
        }

        /// <summary>
        /// Gets the key of the point, a key is used internally as a unique identifier in 
        /// in a <see cref="Series"/> 
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public int Key { get; internal set; }

        /// <summary>
        /// Gets the instance represented by this point.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public TModel Model { get; internal set; }

        /// <summary>
        /// Gets the view model,the model to drawn in the user interface.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public object ViewModel { get; internal set; }

        /// <summary>
        /// Gets the view.
        /// </summary>
        /// <value>
        /// The view.
        /// </value>
        public object View { get; internal set; }

        /// <summary>
        /// Gets or sets the point.
        /// </summary>
        /// <value>
        /// The point.
        /// </value>
        public TCoordinate Coordinate { get; set; }

        /// <summary>
        /// Gets the series that owns the point.
        /// </summary>
        /// <value>
        /// The series.
        /// </value>
        public ISeries Series { get; internal set; }

        /// <summary>
        /// Gets the chart that owns the point.
        /// </summary>
        /// <value>
        /// The chart.
        /// </value>
        public ChartModel Chart { get; internal set; }

        /// <summary>
        /// Gets the tooltip text.
        /// </summary>
        /// <value>
        /// The tooltip text.
        /// </value>
        public string TooltipText => Series.GetTooltipLabel(Coordinate);

        /// <summary>
        /// Gets the data label string.
        /// </summary>
        /// <value>
        /// The data label string.
        /// </value>
        public string DataLabelString => Series.GetDataLabel(Coordinate);

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj, _packingSource);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return _packingSource.GetHashCode();
        }
    }
}